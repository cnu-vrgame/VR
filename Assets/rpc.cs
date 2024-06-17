using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEditor.PackageManager;
using static Autodesk.Fbx.FbxStatus;

public class Rpc : MonoBehaviour
{
    #region private members
    private TcpListener tcpListener;
    private Thread tcpListenerThread;
    private TcpClient connectedTcpClient;
    internal static Rpc instance;
    #endregion

    Queue<int> jobs = new Queue<int>();

    void Awake()
    {
        instance = this;
        Debug.Log("Start Server");

        // Start TcpServer background thread
        tcpListenerThread = new Thread(new ThreadStart(ListenForIncommingRequest));
        tcpListenerThread.IsBackground = true;
        tcpListenerThread.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if (jobs.Count > 0)
        {
            int stat = jobs.Dequeue();
            Debug.Log($"STAT: {stat}");
            HandleIncomingStatus(stat);
        }
    }

    private void HandleIncomingStatus(int status)
    {
        GameObject emoji = GameObject.Find("EmotionPointer");
        if (emoji != null)
        {
            var controller = emoji.GetComponentInChildren<emotioncontroller>();
            if (controller != null)
            {
                controller.setLevel(status);
            }
            else
            {
                Debug.LogError("Controller.. Not presented");
            }
        }
        else
        {
            Debug.LogError("EmotionPointer Not Found");
        }
    }

    internal void AddJob(int code)
    {
        jobs.Enqueue(code);
    }
    // Runs in background TcpServerThread; Handles incomming TcpClient requests
    private void ListenForIncommingRequest()
    {
        try
        {
            tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 50001);
            // tcpListener.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            // tcpListener.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseUnicastPort, true);
            tcpListener.Start();
            Debug.Log("Server is listening");

            while (true)
            {
                using (connectedTcpClient = tcpListener.AcceptTcpClient())
                {
                    // Get a stream object for reading
                    using (NetworkStream stream = connectedTcpClient.GetStream())
                    {
                        // Read incomming stream into byte array.
                        do
                        {
                            Byte[] bytesTypeOfService = new Byte[4];
                            int decodedBytes = stream.Read(bytesTypeOfService, 0, 4);
                            if (!BitConverter.IsLittleEndian)
                            {
                                Array.Reverse(bytesTypeOfService);
                            }

                            int statusCode = BitConverter.ToInt32(bytesTypeOfService, 0);
                            Rpc.instance.AddJob(statusCode);

                            Debug.Log($"STATUS_CODE: {statusCode}");

                        } while (true);
                    }
                }
            }
        }
        catch (SocketException socketException)
        {
            Debug.Log("SocketException " + socketException.ToString());
        }
    }
}
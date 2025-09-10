using UnityEngine;

using System.Net.Sockets;

using System.Text;

public class UdpClientUnity : MonoBehaviour 
{

UdpClient client;

void Start() {

client = new UdpClient();

client.Connect("10.57.10.16", 5000);

Debug.Log("Cliente conectado ao servidor");

}

void Update() {

if
(Input.GetKeyDown(KeyCode.Space)) {

string msg = "Olá do cliente Unity!";

byte[] data =
Encoding.UTF8.GetBytes(msg);

client.Send(data, data.Length);

Debug.Log("Mensagem enviada: " +
msg);

}

}

}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ServerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMessages messages = new ChatMessages();

            messages.AddMessage("Tere");
            messages.AddMessage("Head aega");
            messages.AddMessage("Mul");
            messages.AddMessage("Pole");
            messages.AddMessage("Teile");
            messages.AddMessage("Aega");

            string data = JsonConvert.SerializeObject(messages);
            Console.WriteLine(data);

            ChatMessages receivedMessages = JsonConvert.DeserializeObject<ChatMessages>(data);

            foreach(var message in receivedMessages.messages)
            {
                Console.WriteLine(message.message);
            }


            Console.ReadLine();
            //server server = new server();
            //console.readkey();
            //thread.sleep(1000);
            //client client = new client();

        }
    }
}

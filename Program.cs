using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;

namespace Cybersecurity_Chatbot
{
    public class Program
    {

        static void Main(string[] args)
        {

            Logo();

            Console.WriteLine("Welcome to the Cybersecurity Chatbot! Ask me anything");

             void Logo()
            {
                Console.WriteLine(@"   ______          __                                                             _   _             ______            _    ");
                Console.WriteLine(@" .' ___  |        [  |                                                           (_) / |_          |_   _ \          / |_  ");
                Console.WriteLine(@"/ .'   \_|  _   __ | |.--.   .---.  _ .--.  .--.  .---.  .---.  __   _   _ .--.  __ `| |-' _   __    | |_) |   .--. `| |-' ");
                Console.WriteLine(@"| |        [ \ [  ]| '/'`\ \/ /__\\[ `/'`\]( (`\]/ /__\\/ /'`\][  | | | [ `/'`\][  | | |  [ \ [  ]   |  __'. / .'`\ \| |   ");
                Console.WriteLine(@"\ `.___.'\  \ '/ / |  \__/ || \__., | |     `'.'.| \__.,| \__.  | \_/ |, | |     | | | |,  \ '/ /   _| |__) || \__. || |,  ");
                Console.WriteLine(@" `.____ .'[\_:  / [__;.__.'  '.__.'[___]   [\__) )'.__.''.___.' '.__.'_/[___]   [___]\__/[\_:  /   |_______/  '.__.' \__/  ");
                Console.WriteLine(@"           \__.'                                                                          \__.'                            ");
                Console.WriteLine();
            }

            try
            {
                string soundFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "voiceMessage.wav");

                if (File.Exists(soundFilePath))
                {
                   
                    using (SoundPlayer player = new SoundPlayer(soundFilePath))
                    {
                        player.PlaySync();
                    }
                }
            }
            catch (Exception)
            { 

           
            }


            while (true)
            {
                Console.Write("You: ");
                string userInput = Console.ReadLine().ToLower();

                if (userInput.Contains("hello") || userInput.Contains("hey"))
                {
                    Console.WriteLine("Chatbot: Hello! How can I assist you today?");
                }
                else if (userInput.Contains("what is cybersecurity?"))
                {
                    Console.WriteLine("Chatbot: Cybersecurity is the practice of protecting systems, networks, and programs from digital attacks.");
                }
                else if (userInput.Contains("what are the types of cyber attacks"))
                {
                    Console.WriteLine("Chatbot: Common types of cyber attacks include phishing, malware, ransomware, and denial-of-service attacks.");
                }
                else if (userInput.Contains("how can i protect myself online"))
                {
                    Console.WriteLine("Chatbot: Use strong passwords, enable two-factor authentication, and be cautious of suspicious emails.");
                }
                else if (userInput.Contains("what is phishing"))
                {
                    Console.WriteLine("Chatbot: Phishing is a type of cyber attack where attackers impersonate legitimate organizations to steal sensitive information.");
                }
                else if (userInput.Contains("what is malware"))
                {
                    Console.WriteLine("Chatbot: Malware is malicious software designed to harm or exploit any programmable device or network.");
                }
                else if (userInput.Contains("exit") || userInput.Contains("quit"))
                {
                    Console.WriteLine("Chatbot: Goodbye! Stay safe online.");
                    break;
                }
                else
                {
                    Console.WriteLine("Chatbot: I'm sorry, I don't understand that. Can you ask something else?");
                }
            }
        }
    }
    } 

using System;
using System.IO;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text.Json;

namespace Neural_networks
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputs = {2,4,6,8,10,12,14,16,18,20};

            Perceptron p = new Perceptron(inputs,null);
            float guess = p.guess(inputs);

            Console.WriteLine(guess + " before");
            p.lr = 1;

            p.Train(inputs, 1);


            guess = p.guess(inputs);
            Console.WriteLine(p.guess(inputs) + " it was that");




            p.Train(new double[] { 1, 3, 5 },-1);
            Console.WriteLine(p.guess(new double[] {1,3,5}));;


        }
    }
}

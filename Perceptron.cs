using System;

namespace Neural_networks
{
    class Perceptron
    {
        public int lr;
        public delegate int Activationfunction(double num);
        public double[] weights;
        public Activationfunction activationfunction;

        public Perceptron(double[] inputs,Activationfunction func)
        {
            weights = new double[inputs.Length];
            activationfunction = func;
            Random random = new Random();
            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = random.NextDouble() * 2 - 1;
            }

        }
       
        int Sign(double n)
        {
            if (n >= 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }



        }
        public int guess(double[] inputs)
        {
            double sum = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                sum += inputs[i] * weights[i];



            }
            int output;

            if (activationfunction != null)
            {

                output = activationfunction(double.Parse(sum.ToString()));
            }
            else
            {
                output = Sign(sum);
            }
            return output;

        }
       

        public void Train(double[] inputs,int target)
        {
            int guess = this.guess(inputs);
            int error = target - guess;
            for (int i = 0; i < weights.Length; i++)
            {

                weights[i] += error * inputs[i] * lr;

            }


        }

    }
}

using System;


namespace PasswordGenerator
{
    class password_generator
    {
        private string specjal_marks;
        private string leters;
        private Random random;

        private int volume_of_lowercase;
        private int volume_of_uppercase;
        private int volume_of_specjal;


        string swap_char(string input, int index1, int index2)
        {
            string to_return = string.Empty;
            int length = input.Length;

            char[] _input = input.ToCharArray();
            char pChar = _input[index1];
            _input[index1] = _input[index2];
            _input[index2] = pChar;

            foreach (char c in _input)
            {
                to_return += c;
            }

            return to_return;
        }



        public password_generator()
        {
            //inicjalizacja generatora losowego
            random = new Random(Guid.NewGuid().GetHashCode());

            //inicjalizacja znaków specjalnych
            for (int i = 33; i < 47; i++)
            {
                specjal_marks += Convert.ToChar(i);
            }
            for (int i = 58; i < 64; i++)
            {
                specjal_marks += Convert.ToChar(i);
            }
            for (int i = 91; i < 96; i++)
            {
                specjal_marks += Convert.ToChar(i);
            }
            //inicjalizacja liczników
            volume_of_lowercase = 0;
            volume_of_specjal = 0;
            volume_of_uppercase = 0;
            //inicjalizacja liter
            for (int i = 65; i <= 90; i++)
            {
                leters += Convert.ToChar(i);
            }

        }
        

        private string final_generation(int lower, int upper, int specjal)
        {
            volume_of_lowercase = 0;
            volume_of_specjal = 0;
            volume_of_uppercase = 0;
            string final_password = String.Empty;

            if (lower != 0)
            {
                for (int i = lower; i > 0; i--)
                {
                    final_password += Convert.ToChar((leters[random.Next(0, leters.Length - 1)]).ToString().ToLower());
                }
            }

            if (upper != 0)
            {
                for (int i = upper; i > 0; i--)
                {
                    final_password += Convert.ToChar((leters[random.Next(0, leters.Length - 1)]).ToString().ToUpper());
                }
            }

            if (specjal != 0)
            {
                for (int i = specjal; i > 0; i--)
                {
                    final_password += Convert.ToChar((specjal_marks[random.Next(0, specjal_marks.Length - 1)]));
                }
            }
            for (int i = 0; i < 100; i++)
            {
                final_password = swap_char(final_password, random.Next(0, final_password.Length), random.Next(0, final_password.Length));
            }
            return final_password;
        }

        public string generate(int lenght, int _case)
        {

            string password = String.Empty;
            int moment = 0;
            switch (_case)
            {
                case 15:
                    //lower upper specjal
                    volume_of_lowercase = random.Next(1, lenght - 2);
                    volume_of_specjal = random.Next(1, (lenght - volume_of_lowercase));
                    volume_of_uppercase = random.Next(1, (lenght - volume_of_specjal - volume_of_lowercase));

                    moment = (random.Next(0, 10) % 3);
                    if ((volume_of_lowercase + volume_of_specjal + volume_of_uppercase) != lenght)
                    {
                        switch (moment)
                        {
                            case 0:
                                volume_of_lowercase += (lenght - (volume_of_lowercase + volume_of_specjal + volume_of_uppercase));
                                break;
                            case 1:
                                volume_of_specjal += (lenght - (volume_of_lowercase + volume_of_specjal + volume_of_uppercase));
                                break;
                            case 2:
                                volume_of_uppercase += (lenght - (volume_of_lowercase + volume_of_specjal + volume_of_uppercase));
                                break;
                        }
                    }

                    break;
                case 8:
                    //lower upper
                    volume_of_lowercase = random.Next(1, lenght - 1);
                    volume_of_uppercase = random.Next(1, (lenght - volume_of_lowercase));

                    moment = (random.Next(0, 10) % 2);
                    if ((volume_of_lowercase + volume_of_uppercase) != lenght)
                    {
                        switch (moment)
                        {
                            case 0:
                                volume_of_lowercase += (lenght - (volume_of_lowercase + volume_of_specjal + volume_of_uppercase));
                                break;

                            case 1:
                                volume_of_uppercase += (lenght - (volume_of_lowercase + volume_of_specjal + volume_of_uppercase));
                                break;
                        }
                    }
                    break;
                case 10:
                    //lower specjal
                    volume_of_lowercase = random.Next(1, lenght - 1);
                    volume_of_specjal = random.Next(1, (lenght - volume_of_lowercase));

                    moment = (random.Next(0, 10) % 2);
                    if ((volume_of_lowercase + volume_of_specjal) != lenght)
                    {
                        switch (moment)
                        {
                            case 0:
                                volume_of_lowercase += (lenght - (volume_of_lowercase + volume_of_specjal + volume_of_uppercase));
                                break;

                            case 1:
                                volume_of_specjal += (lenght - (volume_of_lowercase + volume_of_specjal));
                                break;
                        }
                    }
                    break;
                case 12:
                    //upper specjal
                    volume_of_uppercase = random.Next(1, lenght - 1);
                    volume_of_specjal = random.Next(1, (lenght - volume_of_uppercase));

                    moment = (random.Next(0, 10) % 2);
                    if ((volume_of_uppercase + volume_of_specjal) != lenght)
                    {
                        switch (moment)
                        {
                            case 0:
                                volume_of_uppercase += (lenght - (volume_of_uppercase + volume_of_specjal));
                                break;

                            case 1:
                                volume_of_specjal += (lenght - (volume_of_specjal + volume_of_uppercase));
                                break;
                        }
                    }
                    break;
                case 3:
                    //lower
                    volume_of_lowercase = lenght;
                    break;
                case 5:
                    //upper
                    volume_of_uppercase = lenght;
                    break;
                case 7:
                    //specjal
                    volume_of_specjal = lenght;
                    break;
            }
            password = final_generation(volume_of_lowercase, volume_of_uppercase, volume_of_specjal);
            return password;

        }

    }
}

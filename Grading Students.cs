 public static List<int> gradingStudents(List<int> grades)
        {
            List<int> lista = new List<int>();
            
            foreach(var j in grades)
            {
                int count = 0;
                int moment = j;

                if (moment < 38 || moment % 5 == 0)
                {
                    lista.Add(moment);
                }

                else
                {
                    int copy = moment;

                    while (count < 2)
                    {
                        moment++;
                        count++;

                        if (moment % 5 == 0)

                        {
                            lista.Add(moment);
                            break;
                        }

                        if (count == 2)
                    {
                        lista.Add(copy);
                    }
                      
                    }

                                     
                }
            }

            return lista;

        }
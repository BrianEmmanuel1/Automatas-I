using System;
using System.IO;


namespace Automatas_I
{
    public class archivo
    {
        
        StreamReader Archivo = new StreamReader("C:\\Users\\gatog\\OneDrive\\ITQ\\Cuarto Semestre\\Automatas I\\Prueba.txt");
        StreamWriter Copia = new StreamWriter("C:\\Users\\gatog\\OneDrive\\ITQ\\Cuarto Semestre\\Automatas I\\Copia.txt");

        public void desplegar()
        {
            char c;
            int Letras = 0, Num =0, Esp = 0;

            while(!Archivo.EndOfStream)
            {    
                c = (char) Archivo.Read(); 
                Console.Write(c);
                
                Letras = (char.IsLetter(c)) ? Letras+=1 : Letras;
                Num = (char.IsNumber(c)) ? Num+=1 : Num;
                Esp = (c==32) ? Esp +=1: Esp; 
            
                c = (char.ToLower(c) == 'a' || c == 'á') ? '4' : c;
                c = (char.ToLower(c) == 'e' || c=='é') ? '3' : c;
                c = (char.ToLower(c)== 'i' || c == 'í') ? '1' : c;
                c = (char.ToLower(c)== 'o' || c== 'ó') ? '0' : c;
                c = (char.ToLower(c)== 'u' || c== 'ú') ? 'u' : c;

                Copia.Write(c);
               
            }

            Copia.WriteLine("\n\nSe encontraron {0} letras" +
            ", {1} numeros y  {2} espacios", Letras, Num, Esp);
            Console.WriteLine("\n\nSe encontraron {0} letras" +
            ", {1} numeros y  {2} espacios", Letras, Num, Esp);

            Archivo.Close();
            Copia.Close();


        }
    }
}
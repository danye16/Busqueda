﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda
{
    internal class Ejercicios
    {

        public void Lineal1()
        {
            int[] matriz = { 1, 3, 5, 6, 8, };
            Console.WriteLine("Ingrese el numero a buscar del 1 al 10");
            int numero = Convert.ToInt32(Console.ReadLine());
            bool centinela = false;
            for (int i = 0; i < matriz.Length; i++) {
                  if (matriz[i] == numero) { 
                    centinela = true;
                    Console.WriteLine("El numero "+numero +" se encuentra en la posicion "+i);
                }
            }
            if (centinela==false ) {
                Console.WriteLine("EL numero no existe");
            }
        }
        public void Lineal2()
        {
            string[] matriz = { "rojo","azul","verde","rosa" };
            Console.WriteLine("Ingrese un color");
            string color=Console.ReadLine();
            bool centinela = false;
            for (int i = 0; i < matriz.Length; i++)
            {
                if (matriz[i] == color)
                {
                    centinela = true;
                    Console.WriteLine("El color " + color + " se encuentra en la posicion " + i);
                }
            }
            if (centinela == false)
            {
                Console.WriteLine("EL color no existe");
            }
        }
        public void Lineal3()
        {
            int[] matriz = { 1, 3, 5, 6, 8, };
          
            for (int i = 0; i < matriz.Length; i++)
            {
                if (matriz[i]%2 == 0)
                {
                    Console.WriteLine("El numero par  se encuentra en la posicion " + i);
                }
            }
            
        }

        //Busqueda Binaria
        public void Binario1()
        {
            int[] matriz = { 1, 3, 5, 6, 8, };
            Console.WriteLine("Ingrese el numero a buscar del 1 al 10");
            int numero = Convert.ToInt32(Console.ReadLine());
            bool centinela = false;
            int media = 0;
            int inicio = 0;
            int final = 4;
            while (inicio <= final && centinela == false)
            {
                media = (inicio + final) / 2;
                if (matriz[media] == numero) { 
                    centinela = true;
                    Console.WriteLine($"El elemento {numero} se encuentra en la posicion {media} ");
                }
                if (matriz[media]>numero)
                    final= media-1;
                else
                    inicio = media+1;
            }  
            if (centinela==false) 
            {
                Console.WriteLine($"El elemento {numero} no existe ");
            }

        }

        public void Binario2()
        {
            string[] matriz = { "a", "b", "c", "d", "e" };
            Console.WriteLine("Ingrese el caracter a buscar");
            string palabra = Console.ReadLine();
            bool centinela = false;
            int media = 0;
            int inicio = 0;
            int final = matriz.Length;
            while (inicio <= final && centinela == false)
            {
                media = (inicio + final) / 2;
                if (string.Compare(palabra, matriz[media])==0)
                {
                    centinela = true;
                    Console.WriteLine($"El elemento {palabra} se encuentra en la posicion {media} ");
                }
                if (string.Compare(palabra, matriz[media]) < 0)
                    final = media - 1;
                else
                    inicio = media + 1;
            }
            if (centinela == false)
            {
                Console.WriteLine($"El elemento {palabra} no existe ");
            }

        }
        public void Binario3()
        {
            int[] matriz = { 1, 3, 5, 7, 8, };
          
            bool centinela = false;
            int media = 0;
            int inicio = 0;
            int final = 4;
            while (inicio <= final && centinela == false)
            {
                media = inicio + (final-inicio) / 2;
                if (matriz[media] % 2 == 0)
                {
                    centinela = true;
                    Console.WriteLine($"El elemento {matriz[media]} se encuentra en la posicion {media}  y es par");
                
                if (media==0 || matriz[media-1] %2 != 0)
                {
                }
                else
                {
                    final = media - 1;
                }
                }
                else { inicio = media + 1; }
                
            }
            if (centinela == false)
            {
                Console.WriteLine($"El elemento Par no existe ");
            }

        }
    }
 
    

}



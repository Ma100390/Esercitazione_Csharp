/*1)
Scrivere un algoritmo che visualizzi i numeri da 0 a 100 e li salvi in un array.
Al termine scriva l'array dal primo all'ultimo elemento e successivamente lo riscriva in ordine
inverso (dall'ultimo al primo).

3)
Scrivere un algoritmo che prenda in input:
a) La dimensione di un array
b) In base alla dimensione dell'array, x numeri interi
e restituisca:
a) La somma di tutti i numeri inseriti all'interno dell'array
b) La media aritmetica di tutti i numeri inseriti all'interno dell'array */


/*Scrivere un algoritmo che visualizzi i numeri da 0 a 100 e li salvi in un array.
Al termine scriva l'array dal primo all'ultimo elemento e successivamente lo riscriva in ordine
inverso (dall'ultimo al primo).
2)*/

using System;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

/* 
  int n = 0;
do
{
    int numero = 101;
    int[] arr = new int[numero];
    for (int o = 0; o < numero; o++) 
    {
    arr[o] = o;
    Console.WriteLine(arr[o]);
    
   
    };

    int i = 100;
    for (int u = 0; i >= u; i--)
    {
    arr[i] = i;
    Console.WriteLine(arr[i]);
    };

*/
/*
 * 2)
Scrivere un algoritmo che prenda in input un valore di x nomi (decida il candidato la dimensione
dell'array). Dopo aver caricato l'array, specificare un nome da ricercare e stampare se il nome
è presente o meno nell'array caricato precedentemente.*/

/*string  n = "";
Console.WriteLine("scrivere finito per chiudere il programma");
n = Console.ReadLine();
do
{
    
    string NomeDaInserire= "" ;
    Console.WriteLine(NomeDaInserire); 
    NomeDaInserire = Convert.ToString(Console.ReadLine);
    int  Lunghezza = 0;
    Console.WriteLine(Lunghezza);
    Lunghezza = Convert.ToInt32




    string[] arr = new arr[];
    Console.WriteLine();


} while (n == "finito");

*/





/* public class Program
{
    static void Main(string[] args)
    {
        int  n = 0;
        Console.WriteLine();
        
        do
        {
            // INPUT
            Console.Write("Quanti nomi vuoi inserire? ");
            
            int numNomi = int.Parse(Console.ReadLine());
           

            //crea un array di stringhe 
            string[] nomi = new string[numNomi];

            //inserire i nomi nell  array
            Console.WriteLine("Inserisci i nomi uno per riga:");
            for (int i = 0; i < numNomi; i++)
            {
                nomi[i] = Console.ReadLine();
            }

            // cercare
            Console.Write("quale nome cerchi? ");
            string nomeDaCercare = Console.ReadLine();

            // Cerca 
            bool presente = false;
            for (int i = 0; i < numNomi; i++)
            {
                if (nomi[i] == nomeDaCercare)
                {
                    presente = true;
                    break;
                }
            }
            
            // Stampa 
            if (presente)
            {
                Console.WriteLine(nomeDaCercare + " è presente nell'array.");
            }
            else
            {
                Console.WriteLine(nomeDaCercare + " non è presente nell'array.");
            }

            n++;
        } while (0 < n);
    }   
}
*/
/*Scrivere un algoritmo che prenda in input:
a) La dimensione di un array
b) In base alla dimensione dell'array, x numeri interi
e restituisca:
a) La somma di tutti i numeri inseriti all'interno dell'array
b) La media aritmetica di tutti i numeri inseriti all'interno dell'array*/

class Program
{
    static void Main(string[] args)
    {
        // Chiedi all'utente la dimensione dell'array
        Console.Write("Inserisci la dimensione dell'array: ");
        int dimensione = int.Parse(Console.ReadLine());

        // Crea un array di interi della dimensione specificata dall'utente
        int[] numeri = new int[dimensione];

        // Chiedi all'utente di inserire i numeri nell'array
        Console.WriteLine("Inserisci i numeri uno per riga:");
        for (int i = 0; i < dimensione; i++)
        {
            numeri[i] = int.Parse(Console.ReadLine());
        }

        // Calcola la somma dei numeri nell'array
        int somma = 0;
        for (int i = 0; i < dimensione; i++)
        {
            somma += numeri[i];
        }

        // Calcola la media aritmetica dei numeri nell'array
        double media = (double)somma / dimensione;

        // Stampa i risultati
        Console.WriteLine("La somma dei numeri nell'array è: " + somma);
        Console.WriteLine("La media aritmetica dei numeri nell'array è: " + media);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_08___parte_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Váriaveis

            
            List < string > produtos = new List < string > { " Pepsi","Fanta" };
            
            Console.WriteLine( " -- Bem-Vindo ao Conradito Store --" );

            while ( true )
            {

                Console.Write( "\n" );

                Console.Write( " Digite 1 para cadastrar e 2 para listar: " );
                string resposta = Console.ReadLine();

                Console.Clear();

                if ( resposta == "1" )
                {

                    Console.Write( " Digite o nome do produto: " );
                    string produto = Console.ReadLine();
                    produto = produto.ToLower();

                    if ( produtos.Contains( produto ) )
                    {

                        Console.Write( " \n" );
                        
                        Console.WriteLine( " -- Esse produto já está na lista... --" );

                        Console.ReadKey();

                        Console.Clear();

                    }

                    else
                    {

                        produtos.Add( produto );

                        Console.Write( " \n" );
                        
                        Console.WriteLine(" -- Produto adicionado! --");

                        Console.ReadKey();

                        Console.Clear();

                    }



                }

                else
                {

                    string texto = "";                    
                    int contador = 0;

                    while ( contador < produtos.Count )
                    {

                        string nome = produtos[contador] + ", ";

                        string texto_tratado = nome.Substring(0, 1).ToUpper() + nome.Substring( 1 , nome.Length - 1 );

                        texto += texto_tratado;
                            
                        contador++;

                    }
                    
                    texto = texto.Substring( 1 , texto.Length - 2);
                    
                    Console.WriteLine( texto );

                    Console.ReadKey();
                    
                    Console.Clear() ;

                }


            }
            
            
            
        }
    }
}

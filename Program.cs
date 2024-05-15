using System;
using System.Collections.Generic;
using System.Linq;
namespace Program{
    public class Program{
        public static void Main(string[] args){
            var Array = new List<int>{10, 4, 9, 3 , 5, 11, 24, 2, 7}; //Lista desordenada
            Console.WriteLine(string.Join(", ", SelectionSort(Array))); //uso do string.Join para converter para string
        }
        public static int[] SelectionSort(List<int> array){
            var NovoArray = new int[array.Count];
            for( var i = 0; i < NovoArray.Length; i++){
                var menor = BuscaMenor(array);
                NovoArray[i] = array[menor];
                array.RemoveAt(menor);
            }
            return NovoArray;

        }
        public static int BuscaMenor(List<int> array){ 
            var Menor = array[0];
            var menorIndice = 0;

            for(int i = 1; i < array.Count; i++ ){
                if(array[i] < Menor){
                    Menor = array[i];
                    menorIndice = i;
                }
            }
            return menorIndice;
        }

        public static int[] SelectionSort(int[] ArrayDesordenado){
            for(var i = 0; i < ArrayDesordenado.Length; i++){
                var menorIndice = i;
                for(var Remanescente = i + 1; Remanescente < ArrayDesordenado.Length; Remanescente++){
                    if(ArrayDesordenado[Remanescente] < ArrayDesordenado[menorIndice]){
                        menorIndice = Remanescente;
                    }
                }
                (ArrayDesordenado[i], ArrayDesordenado[menorIndice]) = (ArrayDesordenado[menorIndice], ArrayDesordenado[i]);
            }
            return ArrayDesordenado;
        }
    }
}   
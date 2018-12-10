using System;
using Newtonsoft.Json;

namespace Pratica1_SerializeNetCore{
    class Program
    {
        static void Main(string[] args){

            var arraySerializado = DoSerialization();
            System.Console.WriteLine(arraySerializado);
            System.Console.WriteLine(" ======================== ");

            System.Console.WriteLine("  VOILÀAAAAAA ...     ");
            DoDeserialization(arraySerializado);
            


        }       

            // Serialize o array de onibus para uma string Json. 
        public static string DoSerialization() {
       
        Onibus[] variosOnibus = {
            new Onibus{ ID = 503, Empresa = "ViaAgil", Destino = "Parque Tecnológico", VelMax=80.5},
            new Onibus{ ID = 505, Empresa = "ViaAgil", Destino = "Centro de Inovação", VelMax=90.5},
            new Onibus{ ID = 500, Empresa = "ViaAgil", Destino = "Trabalho", VelMax=110.5},
            new Onibus{ ID = 240, Empresa = "ViaAgil", Destino = "CKP ", VelMax = 70.2}
        };

        
            var jsonVariosBus = JsonConvert.SerializeObject(variosOnibus);
        
            return jsonVariosBus;
        }

        // Deserialize a string Json, para um array de objetos do tipo Onibus. 
        public static void DoDeserialization(string jsonVariosBus) {
    
            var variasVans = JsonConvert.DeserializeObject<Van[]>(jsonVariosBus);
    
                foreach (var van in variasVans) {
                    System.Console.WriteLine($"Destino:{van.Destino} Velocidade Máxima:{van.VelMax}");
                 }
            
            }

    }//ClassProgram

}

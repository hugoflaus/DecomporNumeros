using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace api.Business
{
    public class DecomporNumero{
        private IConfiguration _config;
        private List<Int32> divisores { get; set; }
        public DecomporNumero (IConfiguration Config) {
            this._config = Config;
        }

        public List<Int32> retornaDivisores(Int32 numero){
             validaNumero(numero);
             return verificaDivisores(numero);
        }
        public List<Int32> retornaDivisoresPrimos(List<Int32> divisores ,Int32 numero){
           var divisoresPrimos = new List<Int32>();
           foreach (var item in divisores)
           {
               if(verificaNumeroPrimo(item)){
                 divisoresPrimos.Add(item);
               }
           }
           return divisoresPrimos;
        }


        private List<Int32> verificaDivisores(Int32 numero){
            var divisores = new List<Int32>();
                
            for (int i = 1; i <= numero; i++)
            {
                if(numero % i == 0){
                    divisores.Add(i);
                }
            }
        
            return divisores;
        }

        private bool verificaNumeroPrimo(Int32 numero){
            bool primo = true;
            int fator = numero / 2;
            int i = 0;
            for (i = 2; i <= fator; i++)
            {
                if ((numero % i) == 0)
                    primo = false;
           }
            return primo;
        }

        public void validaNumero(Int32 numero){
            if(numero < 0){
                throw new Exception("Informe um número natural ou seja um número positivo");
            }else if( numero == 1){
                throw new Exception("1 divide ele mesmo mas não é primo");
            }
        }
    }
}
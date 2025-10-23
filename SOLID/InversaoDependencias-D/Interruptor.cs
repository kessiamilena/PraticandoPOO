
namespace InversaoDependencias_D
{
    public class Interruptor
    {
        // privada somente leitura, variavel criada como dispositivo
        private readonly IDispositivo variavel_dispositivo_que_vem_da_interface;
        private ArCondicionado ar;

        // jeito errado ❌
        public Interruptor()
        {
            ar = new ArCondicionado();
        }

        // jeito correto ✅
        // public Interruptor(IDispositivo parametro_dispositivo) // _dispositivo
        // {
        //     //this.dispositivo para nao confundir as variaveis
        //     variavel_dispositivo_que_vem_da_interface = parametro_dispositivo;
        // }

        //public void Acionar() => variavel_dispositivo_que_vem_da_interface.Ligar();

        // jeito errado ❌
        public void Acionar()
        {
            ar.Ligar();
        }
    }
}
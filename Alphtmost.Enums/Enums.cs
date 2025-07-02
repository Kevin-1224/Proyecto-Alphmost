namespace Alphtmost.Enums
{
    public class Enums
    {
        public enum EstadoCancion
        {
            Pendiente,
            Aprobada,
            Rechazada
        }
        public enum EstadoPago
        {
            Pendiente,
            Completado,
            Fallido
        }
        public enum TipoPlanPremium
        {
            Normal,
            Familiar,
            Empresarial
        }
        public enum EstadoTransaccion
        {
            Aprobada,
            Rechazada,
            Pendiente
        }
        public enum Genero
        {
            Masculino,
            Femenino,
            Otro
        }
        public enum GeneroMusical
        {
            Rock = 1,
            Pop = 2,
            Jazz = 3,
            Clasica = 4,
            Rap = 5,
            Otro = 6
        }


    }
}


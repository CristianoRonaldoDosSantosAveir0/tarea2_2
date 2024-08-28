using System.ComponentModel;

public interface destinatario
    {
        string Name();
    }
    public interface Carta
    {
        string Cartasas();
        string metodo();
    }

    public class mensaje : Carta
    {
        public string Cartasas()
        {
            return "Carta para mi jefe, ";
        }
        public string metodo()
        {
            return "sin modifcaciones ";
        }
    }
    public abstract class CartaMetodo : Carta
    {
        protected Carta Metodo;
        public CartaMetodo(Carta Cartasa)
        {
            this.Metodo = Cartasa;
        }
        public virtual string Cartasas()
        {
            return Metodo.Cartasas();
        }
        public virtual string metodo()
        {
            return Metodo.metodo();
        }
    }
    public class MensajeEncriptado : CartaMetodo
    {
        public MensajeEncriptado(Carta Cartasa) : base(Cartasa) { }
        public override string Cartasas()
        {
            return base.Cartasas();
        }
        public override string metodo()
        {
            return "No se puede leer la carta,carta encriptada";
        }

    }
    public class ComprimirMensaje : CartaMetodo
    {
        public ComprimirMensaje(Carta Cartasa) : base(Cartasa) { }
        public override string Cartasas()
        {
            return base.Cartasas() + "";
        }
        public override string metodo()
        {
            return "La carta pesa lo suficiente para leer en cualquier dispositivo";
        }

    }
    public class FirmarMensaje : CartaMetodo
    {
        public FirmarMensaje(Carta Cartasa) : base(Cartasa) { }
        public override string Cartasas()
        {
            return base.Cartasas() + "";
        }
        public override string metodo()
        {
            return "Firmada por Juan Martinez";
        }

    }
class program
{
    public static void Main(string[] args)
    {
        bool otra = true;
        do
        {
            List<string> cartas = [];
        List<string> metodo = [];

        Console.WriteLine("....................");
        Console.WriteLine("1) añadir carta");
        Console.WriteLine("2)");
        Console.WriteLine("3)");
        string respuesta = Console.ReadLine();
        switch(respuesta)
        {
            case "1":
                Console.WriteLine("nombre disnatario");
                string aña = Console.ReadLine();
                int añas = int.Parse(aña);
                cartas.Add(aña);
                Console.WriteLine("Contenido");
                string con = Console.ReadLine();
                break;
            case "2":
                
                break;
        }

        Carta carta = new mensaje();
        Console.WriteLine(carta.Cartasas() + "" + carta.metodo());

        carta = new MensajeEncriptado(carta);
        Console.WriteLine(carta.Cartasas() + "" + carta.metodo());


        carta = new ComprimirMensaje(carta);
        Console.WriteLine(carta.Cartasas() + "" + carta.metodo());


        carta = new FirmarMensaje(carta);
        Console.WriteLine(carta.Cartasas() + "" + carta.metodo());
        } while (otra);
    }
}

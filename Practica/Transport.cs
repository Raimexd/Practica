

using System.Security.Cryptography.X509Certificates;

abstract class Transport
{
    private int Speed;
    private string motor;
    private string Color;
    private string rights;
    private string Model;
    private bool rent;
    private int wheel;
    public string Motor { get { return motor; } set { Motor = value; } }
    public string color { get { return Color; } set { color = value; } }
    public string CategoryofRights { get {return rights; } set { CategoryofRights = value; } }
    public string model { get { return Model; } set { model = value; } }
    public int speed { get { return Speed; } set { speed = value; } }
    public bool isArended { get {return rent; } set {isArended = value; } }
    public int Wheels { get {return wheel; } set {Wheels = value; } }

    public abstract void AboutTransport();
}


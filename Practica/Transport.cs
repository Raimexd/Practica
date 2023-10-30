

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
    public string Motor { get { return motor; } set { motor = value; } }
    public string color { get { return Color; } set { Color = value; } }
    public string CategoryofRights { get { return rights; } set { rights = value; } }
    public string model { get { return Model; } set { Model = value; } }
    public int speed { get { return Speed; } set { Speed = value; } }
    public bool IsArended { get { return rent; } set { rent = value; } }
    public int Wheels { get { return wheel; } set { wheel = value; } }


    public abstract void AboutTransport();
}


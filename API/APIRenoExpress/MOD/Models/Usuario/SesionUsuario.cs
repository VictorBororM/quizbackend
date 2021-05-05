/// <summary>
/// Summary description for SesionUsuario
/// </summary>
public class SesionUsuario
{
    private int usuario;
    private string usuario_nombre;
    private string usuario_nombre_completo;
    private int rol;
    private string rol_name;
    private string cod_pais;
    private string cod_emp;
    private bool resultado;
    private string mensaje;
    private string ip;
    private string token;
    private string pais;
    private string date_of_birth;

    public string Mensaje
    {
        get { return this.mensaje; }
        set { this.mensaje = value; }
    }

    public bool Resultado
    {
        get { return this.resultado; }
        set { this.resultado = value; }
    }


    public int Usuario
    {
        get { return this.usuario; }
        set { this.usuario = value; }
    }

    public string Usuario_nombre
    {
        get { return usuario_nombre; }
        set { this.usuario_nombre = value; }
    }

    public string Usuario_nombre_completo
    {
        get { return usuario_nombre_completo; }
        set { this.usuario_nombre_completo = value; }
    }

    public int Rol
    {
        get { return rol; }
        set { this.rol = value; }
    }

    public string Rol_nombre
    {
        get { return rol_name; }
        set { this.rol_name = value; }
    }

    public string Cod_emp
    {
        get { return cod_emp; }
        set { this.cod_emp = value; }
    }

    public string Cod_Pais
    {
        get { return cod_pais; }
        set { this.cod_pais = value; }
    }

    public string Ip
    {
        get { return ip; }
        set { this.ip = value; }
    }

    public string Token
    {
        get { return token; }
        set { this.token = value; }
    }

    public string Pais
    {
        get { return pais; }
        set { this.pais = value; }
    }

    public string Date_of_birth
    {
        get { return date_of_birth; }
        set { this.date_of_birth = value; }
    }

}

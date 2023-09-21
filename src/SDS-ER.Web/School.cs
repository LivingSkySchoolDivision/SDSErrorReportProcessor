public class School
{
    public string DAN { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public School(string dan, string name, string email)
    {
        this.DAN = dan;
        this.Name = name;
        this.Email = email;
    }
}
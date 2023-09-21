using System.Text;

public class SDSErrorRecord
{
    public string DivisionID { get; set; }
    public string SchoolID { get; set; }
    public string SchoolName { get; set; }
    public string IndividualID { get; set; }
    public string RecordID { get; set; }
    public DateTime Time { get; set; }
    public string MessageID { get; set; }
    public string ObjectType { get; set; }
    public string Message { get; set; }

    public override string ToString()
    {
        StringBuilder returnMe = new StringBuilder();

        returnMe.Append("{ ");
        returnMe.Append(" DivisionID: " + this.DivisionID);
        returnMe.Append(", SchoolID: " + this.SchoolID);
        returnMe.Append(", SchoolName: " + this.SchoolName);
        returnMe.Append(", IndividualID: " + this.IndividualID);
        returnMe.Append(", RecordID: " + this.RecordID);
        returnMe.Append(", Time: " + this.Time);
        returnMe.Append(", MessageID: " + this.MessageID);
        returnMe.Append(", ObjectType: " + this.ObjectType);
        returnMe.Append(", Message: " + this.Message);
        returnMe.Append(" }");
        
        return returnMe.ToString();
    }
}
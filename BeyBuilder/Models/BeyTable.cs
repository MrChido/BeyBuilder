using System.ComponentModel.DataAnnotations;
public class BeyTable
{
    [Key]//This tells EF Core this is the Primary Key
    public int BeyID { get; set; }
    public string BeyName { get; set; }
    public string EnergyLayer { get; set; }
    public string ForgeDisc { get; set; }
    public string PerformanceTip { get; set; }
    public string Series { get; set; }
    public string SpinDirection { get; set; }
}
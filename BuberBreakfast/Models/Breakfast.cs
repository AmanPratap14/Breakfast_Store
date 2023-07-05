namespace BuberBreakfast.Models;

public class Breakfast
{
    public Guid Id { get; }
    public String Name { get; }
    public string Description { get; }
    public DateTime StartDateTime { get; }
    public DateTime EndDateTime { get; }
    public DateTime LastModifiedDateTime { get; }
    public List<String> Savory { get; }
    public List<string> Sweet { get; }

    public Breakfast(
        Guid id, 
        string name, 
        string description, 
        DateTime startDateTime, 
        DateTime endDateTime, 
        DateTime lastModifiedDateTime, 
        List<String> savory, 
        List<String> sweet)
        {
            //enforce logic
            Id= id;
            Name = name;
            Description =description;
            StartDateTime =startDateTime;
            EndDateTime =endDateTime;
            LastModifiedDateTime =lastModifiedDateTime;
            Savory =savory;
            Sweet =sweet;

        }

}
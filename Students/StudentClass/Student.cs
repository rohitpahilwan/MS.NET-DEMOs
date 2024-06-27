namespace StudentClass;

public class Student
{
  public int id { get; set; }

  public string name { get; set; }

  public float percentage { get; set; }

  public Student(int id, string name, float percentage) { this.id = id; this.name = name; this.percentage = percentage; }

  public Student() { }

  public override string ToString()
  {
    return "Your id is -> " + this.id + "\nYour Name is -> " + this.name + "\nYour Percentage is -> " + this.percentage;
  }
}

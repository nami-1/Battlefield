namespace Battlefield;
public class Student
{
    public string Name;
    public int Teknik;
    public int Foto;
    public int Nätverk; 

    public string GetGrade(int competence)
  {
    int result = Random.Shared.Next(competence);
    if (result == 0)
    {
      return "F";
    }
    else if (result == 1)
    {
      return "E";
    }
    else if (result == 2)
    {
      return "C";
    }
    else
    {
      return "A";
    }
  }

  public string GetPhotoGrade()
  {
    return GetGrade(Foto);
  }

  public string GetEngineerGrade()
  {
    return GetGrade(Teknik);
  }

  public string GetNetworkGrade()
  {
    return GetGrade(Nätverk);
  }



}
 
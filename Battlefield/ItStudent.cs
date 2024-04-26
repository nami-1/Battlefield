namespace Battlefield;
public class ItStudent:Student
{
    public ItStudent() {
        Foto = Random.Shared.Next (0,2); 
        Nätverk = Random.Shared.Next (3,8);
        Teknik = Random.Shared.Next (1,5);
    }
    
}

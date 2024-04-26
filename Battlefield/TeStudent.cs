namespace Battlefield;
public class TeStudent:Student
{
     public TeStudent() {
        Foto = Random.Shared.Next (1,4); 
        Nätverk = Random.Shared.Next (2,5);
        Teknik = Random.Shared.Next (5,9);
    }
}

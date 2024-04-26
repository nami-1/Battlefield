namespace Battlefield;
public class EsStudent:Student
{
     public EsStudent() {
        Foto = Random.Shared.Next (4,9); 
        Nätverk = Random.Shared.Next (1,3);
        Teknik = Random.Shared.Next (0,2);
    }

}

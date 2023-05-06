using UnityEngine;

public class Playsound : MonoBehaviour
{
    public AudioSource click;
    public void Clicky()
    {
        click.Play();
    }
}

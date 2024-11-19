using UnityEngine;

public class PlayerCollision : MonoBehaviour 
{
    public PlayerScript playerscript ;
    public Score score ;
    public GameControl gamecontrol ;
    public AudioSource audioSource ;
    public AudioSource audioSource1 ;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collectables")
        {
            audioSource.Play();
            score.Addscore(5) ;
            Destroy(other.gameObject) ;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Obstacles")
        {
            audioSource1.Play();
            playerscript.enabled = false ;
            gamecontrol.GameOver() ;
        }
    }
}

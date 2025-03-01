using UnityEngine;

public class TrashCleanup : MonoBehaviour
{

    public ParticleSystem bombCollisionParticleSystem;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("ground"))
        {
            Destroy(gameObject);
            ParticleSystem particle = Instantiate(bombCollisionParticleSystem, transform.position, Quaternion.identity);
            particle.Play();
            Destroy(particle.gameObject, particle.main.duration);
        }
    }
}

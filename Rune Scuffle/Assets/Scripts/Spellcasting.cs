using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spellcasting : MonoBehaviour
{
    public GameObject fireballPrefab;
    public GameObject thunderWaveEffect;
    public GameObject thunderWaveField;
    public GameObject counterspellField;
    public GameObject portal;
    public GameObject portalScene;
    public GameObject summoned;
    public GameObject shieldPrefab;
    private Transform pov;

    void Start()
    {
        pov = Camera.main.transform;
    }

    void Update()
    {
        
    }

    public void OnGestureCompleted(GestureCompletionData test)
    {
        print(test.gestureID + " " + test.similarity);
        if (test.similarity >= 0.2)
        {
            print(test.gestureID + " " + test.similarity);
            switch (test.gestureID)
            {
                case 0:
                    print("Detected Fireball");
                    fireball();
                    break;
                case 1:
                    print("Detected Lightning Bolt");
                    lightningBolt();
                    break;
                case 2:
                    print("Detected Thunderwave");
                    thunderWave();
                    break;
                case 3:
                    print("Detected Shield");
                    shield();
                    break;
                case 4:
                    print("Detected Heal");
                    heal();
                    break;
                case 5:
                    print("Detected Teleport");
                    teleport();
                    break;
                case 6:
                    print("Detected Summon");
                    summon();
                    break;
                default:
                    print("Detected nothing, fizzled");
                    break;
            }
        }
        else
        {
            print("Fizzled");
        }
    }

    void fireball() {
        //Debug.Log("Fireballing");
        GameObject ball = Instantiate(fireballPrefab, pov.position + pov.forward * 1, pov.rotation);
        ball.transform.Rotate(90, 0, 0);
        ball.GetComponent<Rigidbody>().velocity = pov.forward * 25;
    }

    void lightningBolt() {
        print("lightning bolt");
    }

    void thunderWave() {
        Debug.Log("Thunderwaving");
        Quaternion rotation = new Quaternion(pov.rotation.x, pov.rotation.y, 0, pov.rotation.w);
        GameObject particleEffect = Instantiate(thunderWaveEffect, pov.position + pov.forward * 0.5F, pov.rotation);
        GameObject field = Instantiate(thunderWaveField, pov.position + pov.forward * 2.0F, pov.rotation);
        Destroy(particleEffect, 1);
        Destroy(field, 0.025F);
    }
    void shield() {
        print("shield");
    }

    void heal() {
        print("heal");
    }

    void teleport() {
        print("teleport");
    }

    void summon() {
        Debug.Log("Summoning");
        GameObject particleEffect = Instantiate(portal, pov.position + pov.forward * 5.0F, pov.rotation);
    }

    void fizzle() {
        Debug.Log("Spell Fizzled");
        //Just play fizzle animation
    }

    void counterspell() {
        Quaternion rotation = new Quaternion(pov.rotation.x, pov.rotation.y, 0, pov.rotation.w);
        GameObject field = Instantiate(counterspellField, pov.position + pov.forward * 2.0F, pov.rotation);
        Destroy(field, 0.25F);
        print("counterspell");
    }


}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PickUpNote : MonoBehaviour
{
    //Ele alma mesafesi.
    public float distance;

    //Not Ekranı
    public GameObject NoteScreen;
    public Image note_Image;

    //Ekranda gösterilecek notlar:
    public Sprite Note1;
    public Sprite Note2;
    public Sprite Note3;
    public Sprite Note4;
  


    //Ekranda gözükecek olan yazılar:
    public Text note_Text;
    public string[] note_Strings;

    public Camera camera_player;

    void Update()
    {
        //Vector3 forward = transform.TransformVector(Vector3.forward);
        RaycastHit hit;
        Ray ray = camera_player.ScreenPointToRay(Input.mousePosition);
        
        Debug.DrawRay(ray.origin,ray.direction,Color.green);
       

        if (Physics.Raycast(ray,out hit))
        {
            
            
            //NOTLAR\\
            //NOTLARI ELE ALMA
            if (hit.distance <= distance && hit.collider.gameObject.tag == "Note1")
            {

                if (Input.GetKeyDown(KeyCode.F))
                {
                    NoteScreen.SetActive(true);
                    note_Image.sprite = Note1;
                    note_Text.text = note_Strings[0];
                    Destroy(hit.collider.gameObject);
                    
                }
            }

            if (hit.distance <= distance && hit.collider.gameObject.tag == "Note2")
            {

                if (Input.GetKeyDown(KeyCode.F))
                {
                    NoteScreen.SetActive(true);
                    note_Image.sprite = Note2;
                    note_Text.text = note_Strings[0];
                    Destroy(hit.collider.gameObject);

                }
            }

            if (hit.distance <= distance && hit.collider.gameObject.tag == "Note3")
            {

                if (Input.GetKeyDown(KeyCode.F))
                {
                    NoteScreen.SetActive(true);
                    note_Image.sprite = Note3;
                    note_Text.text = note_Strings[0];
                    Destroy(hit.collider.gameObject);

                }
            }

            if (hit.distance <= distance && hit.collider.gameObject.tag == "Note4")
            {

                if (Input.GetKeyDown(KeyCode.F))
                {
                    NoteScreen.SetActive(true);
                    note_Image.sprite = Note4;
                    note_Text.text = note_Strings[0];
                    Destroy(hit.collider.gameObject);

                }
            }

           
        }

        if (Input.GetKey(KeyCode.C))
        {
            note_Text.enabled = true;
        }

        else
        {
            note_Text.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            NoteScreen.SetActive(false);
            note_Image.sprite = null;
        }
    }
}

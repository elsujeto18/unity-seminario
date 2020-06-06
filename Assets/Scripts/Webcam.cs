using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Webcam : MonoBehaviour
{


    public RawImage imageCam;
    public RawImage imagenShot;
    private WebCamTexture webCamTexture;
    private string filenName = "foto";
   // private string savePath = Application.persistentDataPath;
    private int captureCounter = 0;

    //private byte[] bytes;
    private Texture2D snap;

    void Start()
    {
        webCamTexture = new WebCamTexture();
        imageCam.texture = webCamTexture;
        webCamTexture.Play();
    }

    public void ButtonSnapShot()
    {
        StartCoroutine("GuardarImagenCam");

    }

    private IEnumerator GuardarImagenCam()
    {

        yield return new WaitForEndOfFrame();

        snap = new Texture2D(webCamTexture.width, webCamTexture.height);

        //bytes = snap.EncodeToPNG();

        snap.SetPixels(webCamTexture.GetPixels());
        snap.Apply();
        imagenShot.texture = snap as Texture;
        System.IO.File.WriteAllBytes(Application.persistentDataPath + filenName + captureCounter.ToString() + ".png", snap.EncodeToPNG());

        ++captureCounter;
    }


























    /*int currentCamIndex = 0;

    WebCamTexture tex;
    public RawImage display;


   



    public void StartStopCam_Clicked()
    {

        if(tex != null)
        {
            display.texture = null;
            tex.Stop();
            tex = null;
        }
        else
        {
            WebCamDevice device = WebCamTexture.devices[currentCamIndex];
            tex = new WebCamTexture(device.name);
            display.texture = tex;

            tex.Play();
        }
        

            

           /*StartCoroutine(TakePhoto());






    }*/



    /*IEnumerator TakePhoto()
    {
        yield return new WaitForEndOfFrame();

        Texture2D photo = new Texture2D(tex.width, tex.height);
        photo.SetPixels(tex.GetPixels());
        photo.Apply();

        byte[] bytes = photo.EncodeToPNG();
        File.WriteAllBytes( Application.dataPath + "photo.png", bytes);

    }*/


}

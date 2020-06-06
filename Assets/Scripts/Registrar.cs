using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using Debug = UnityEngine.Debug;

public class Registrar : MonoBehaviour
{

    public InputField nombreField;

    public Text nivelMostrado;
    public Text nombre;
    public Button submitButton;
    public Text niveltxt;

    public void GuardarDatos()
    {
        PlayerPrefs.SetString("Nombre", nombreField.text);
        PlayerPrefs.SetString("Nivel", niveltxt.text);
       
        
    }

    public void CargarDatos()
    {
        
        nombre.text = PlayerPrefs.GetString("Nombre");
        nivelMostrado.text = PlayerPrefs.GetString("Nivel");
       
    }

    public void EliminarDatos()
    {

        PlayerPrefs.DeleteAll();

    }

    public void Verificar()
    {
        submitButton.interactable = (nombreField.text.Length >= 2 );
    }














    /*public InputField nombreField;
    public InputField cedulaField;
    public InputField direccionField;
    public Button submitButton;

    public void LLamadaRegistro()
    {
        StartCoroutine(Registro());
    }


    IEnumerator Registro()
    {
        WWWForm form = new WWWForm();
        form.AddField("nombre", nombreField.text);
        form.AddField("cedula", cedulaField.text);
        form.AddField("direccion", direccionField.text);

        WWW www = new WWW("http://localhost/ConexionSQL/registro.php", form);

        yield return www;

        if (www.text == "0")
        {
            Debug.Log("Se registro Satisfactoriamente");
        }
        else
        {
            Debug.Log("Error en el registro " + www.text);
        }

    }

    public void Verificar()
    {
        submitButton.interactable = (nombreField.text.Length >= 2 && cedulaField.text.Length == 10 && direccionField.text.Length >= 5);
    }*/

}

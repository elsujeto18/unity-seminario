/*
 * Los creditos van para HenrikPoulsen https://github.com/HenrikPoulsen/SimpleJSON
 * se necesito SimpleJSON, ya que nos ayudara a hacer un parsing del JSON. 
 * esta fue la alternativa que se utilizo.
 */

using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;
using UnityEngine.Networking;
using TMPro;
using System.Globalization;

public class LoadJSON : MonoBehaviour
{
    public GameObject inputTxt;
    public GameObject countryTxt;
    public GameObject currencyTxt;
    public GameObject cityTxt;
    public GameObject continentTxt;

    /*public TMP_InputField inputTxt;
    public TMP_Text countryTxt;
    public TMP_Text currencyTxt;
    public TMP_Text cityTxt;
    public TMP_Text continentTxt;*/

    public void GetJsonData()
    {
        StartCoroutine(RequestWebService());
    }

    IEnumerator RequestWebService()
    {
        string getDataUrl = "http://www.geoplugin.net/json.gp?ip=" + inputTxt.GetComponent<Text>().text;
        print(getDataUrl);

        using (UnityWebRequest webData = UnityWebRequest.Get(getDataUrl))
        {

            yield return webData.SendWebRequest();
            if (webData.isNetworkError || webData.isHttpError)
            {
                print("---------------- ERROR ----------------");
                print(webData.error);
            }
            else
            {
                if (webData.isDone)
                {
                    JSONNode jsonData = JSON.Parse(System.Text.Encoding.UTF8.GetString(webData.downloadHandler.data));

                    if (jsonData == null)
                    {
                        print("---------------- NO DATA ----------------");
                    }
                    else
                    {
                        print("---------------- JSON DATA ----------------");
                        print("jsonData.Count:" + jsonData.Count);
                        countryTxt.GetComponent<Text>().text = jsonData["geoplugin_countryName"];
                        currencyTxt.GetComponent<Text>().text = jsonData["geoplugin_currencyCode"];
                        cityTxt.GetComponent<Text>().text = jsonData["geoplugin_city"];
                        continentTxt.GetComponent<Text>().text = jsonData["geoplugin_continentName"];
                    }
                }
            }
        }
    }
}


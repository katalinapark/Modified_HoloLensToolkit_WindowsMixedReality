using Academy.HoloToolkit.Unity;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;
using UnityEngine.SceneManagement;

public class BodyManager : Singleton<BodyManager>
{

    public GameObject other; 

    // KeywordRecognizer object.
    KeywordRecognizer keywordRecognizer;

    // Defines which function to call when a keyword is recognized.
    delegate void KeywordAction(PhraseRecognizedEventArgs args);
    Dictionary<string, KeywordAction> keywordCollection;

    void Start()
    {
        keywordCollection = new Dictionary<string, KeywordAction>();

        // Add keyword Expand Model to call the ExpandModelCommand function.

        // Add keyword Reset Model to call the ResetModelCommand function.


        keywordCollection.Add("Show Healthy Kidney", ShowHealthyKidneyCommand);
        keywordCollection.Add("Show Kidney Overview", ShowKidneyOverviewCommand);
        keywordCollection.Add("Show Artery", ShowArteryCommand);
        keywordCollection.Add("Show Vein", ShowVeinCommand);
        keywordCollection.Add("Show Collecting", ShowCollectingCommand);
        keywordCollection.Add("Show Kidney Cancer", ShowKidneyCancerCommand);
        keywordCollection.Add("Show Main Menu", ShowMainMenuCommand);
        keywordCollection.Add("About The Kidney", AboutKidneyCommand);
        keywordCollection.Add("About The Study", AboutStudyCommand);
        keywordCollection.Add("About The Surgery", AboutSurgeryCommand); 

        // Initialize KeywordRecognizer with the previously added keywords.
        keywordRecognizer = new KeywordRecognizer(keywordCollection.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        KeywordAction keywordAction;

        if (keywordCollection.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke(args);
        }
    }

    private void ShowHealthyKidneyCommand (PhraseRecognizedEventArgs args)
    {
        other.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("HealthyKidneyScene", LoadSceneMode.Single); 
        
    }

    private void ShowKidneyOverviewCommand (PhraseRecognizedEventArgs args)
    {
        other.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("InitialScene", LoadSceneMode.Single);

    }

    private void AboutKidneyCommand(PhraseRecognizedEventArgs args)
    {
        other.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("InitialScene", LoadSceneMode.Single);

    }


    private void ShowArteryCommand(PhraseRecognizedEventArgs args)
    {
        other.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("ArteryScene", LoadSceneMode.Single);

    }

    private void ShowVeinCommand(PhraseRecognizedEventArgs args)
    {
        other.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("VeinScene", LoadSceneMode.Single);

    }

    private void ShowCollectingCommand (PhraseRecognizedEventArgs args)
    {
        other.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("CollectingScene", LoadSceneMode.Single);

    }

    private void ShowMainMenuCommand (PhraseRecognizedEventArgs args)
    {
        other.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single); 
    }

    private void ShowKidneyCancerCommand(PhraseRecognizedEventArgs args)
    {
        other.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("UnhealthyKidneyScene", LoadSceneMode.Single);

    }


    private void AboutStudyCommand (PhraseRecognizedEventArgs args)
    {
        other.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("InformationalScene", LoadSceneMode.Single);

    }

    private void AboutSurgeryCommand (PhraseRecognizedEventArgs args)
    {
        other.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Surgery", LoadSceneMode.Single);
    }
}
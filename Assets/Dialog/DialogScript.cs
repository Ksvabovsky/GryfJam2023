using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogScript : MonoBehaviour
{

    private List<List<DialogLine>> allDialogLines = DialogContainer.UtworzListeDialogow();
    private List<DialogLine> currDialog;
    private bool readyDialog;
    public int iteration;

    public GameObject laser;


    //left
    public TextMeshProUGUI panelText;
    public Image leftPortrait;
    public TextMeshProUGUI leftPor;

    //right
    public Image rightPortrait;
    public TextMeshProUGUI rightPor;

    private Color activePortrait = new Color(255, 255, 255, 255);
    private Color inactivePortrait = new Color(155, 155, 155, 255);

    public List<Sprite> portraits;
    public List<AudioClip> dialogAudios;
    private AudioSource audioSource;

    public bool isPlaying;
    public bool shouldPlay;



    void Start()
    {
        readyDialog = false;
        shouldPlay = false;
        isPlaying = false;
        iteration = 0;
        audioSource = GetComponent<AudioSource>();
        InitDialog(DialogContainer.dialogTag);
        laser.SetActive(false);

        panelText.text = null;
        leftPor.text = null;
        rightPor.text = null;
        leftPortrait.color = new Color(1f, 1f, 1f, 0f);
        rightPortrait.color = new Color(1f, 1f, 1f, 0f);
    }

    void Update()
    {
        
        if (readyDialog)
        {
            
            if (Input.GetKeyDown(KeyCode.F) && iteration < currDialog.Count)
            {
                if (!isPlaying)
                {
                    shouldPlay = true;
                }
                else
                {
                    StopAudioClip();
                    shouldPlay = true;
                }
                InitCurrLine(iteration);
                iteration++;
            }
        }
    }

    public void InitDialog(int i)
    {
        if (i<=0 || i>allDialogLines.Count)
        {
            Debug.Log("ERROR this line does not exist");
        }
        else
        {
            
            currDialog = allDialogLines[i - 1];
            
            //Debug.Log(currDialog.Count);
            readyDialog = true;
        }

    }

    public void InitCurrLine(int i)
    {
        laser.SetActive(false);
        panelText.text = null;

        leftPor.text = null;
        rightPor.text = null;


        if (currDialog[i].actor.isMainChar)
        {
            //LEFT
            panelText.alignment = TextAlignmentOptions.Left;
            panelText.text = currDialog[i].text;
            leftPor.text = currDialog[i].actor.name;
            leftPortrait.color = Color.white;
            leftPortrait.sprite = portraits[currDialog[i].actor.portraitTag];
            audioSource.clip = dialogAudios[currDialog[i].actor.SFXTag];

            if (rightPortrait.sprite != null)
            {
                rightPortrait.color = Color.grey;
            }
        }else if(currDialog[i].actor.portraitTag == 2)
        {
            laser.SetActive(true);
            panelText.text = currDialog[i].text;
        }
        else if(!currDialog[i].actor.isMainChar)
        {
            //RIGHT
            panelText.alignment = TextAlignmentOptions.Right;
            panelText.text = currDialog[i].text;
            rightPor.text = currDialog[i].actor.name;
            rightPortrait.color = Color.white;
            rightPortrait.sprite = portraits[currDialog[i].actor.portraitTag];
            audioSource.clip = dialogAudios[currDialog[i].actor.SFXTag];

            if (leftPortrait.sprite != null)
            {
                leftPortrait.color = Color.grey;           
            }
        }

        if (shouldPlay && !isPlaying)
        {
<<<<<<< Updated upstream
            PlayAudioClip(currDialog[i].actor.SFXTag);
=======
            PlayAudioClip(i);
>>>>>>> Stashed changes
            shouldPlay = false;
        }
    }


    void PlayAudioClip(int i)
    {
<<<<<<< Updated upstream
        isPlaying = true;
        audioSource.clip = dialogAudios[i];
        audioSource.Play();
=======
       // isPlaying = true;
        //audioSource.clip = dialogAudios[i];
        
        //audioSource.Play();
>>>>>>> Stashed changes
    }

    void StopAudioClip()
    {
        isPlaying = false;
        audioSource.Stop();
    }

}

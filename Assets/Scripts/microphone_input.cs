using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.iOS;

public class microphone_input : MonoBehaviour
{
    // Start is called before the first frame update

    private static int VOLUME_DATA_LENGTH = 128;    //录制的声音长度

    public float volume = 1;        //音量

    private AudioClip mMicrophoneRecode;  //录制的音频
    private string mDeviceName;           //设备名称

    private const int frequency = 44100; //码率
    private const int lengthSec = 999;   //录制时长

    // Use this for initialization
    IEnumerator Start () {
        
        // detect microphone.
        findMicrophones();

        yield return Application.RequestUserAuthorization(UserAuthorization.Microphone);
        if (Application.HasUserAuthorization(UserAuthorization.Microphone))
        {
            Debug.Log("Microphone found");
        }
        else
        {
            Debug.Log("Microphone not found");
        }


        // //get all devices name
        //  foreach (var device in Microphone.devices)
        // {
        //     Debug.Log("Name: " + device);
        // }
        
        mDeviceName = Microphone.devices[0].ToString();
        print(Microphone.devices[0]);

        //record a piece of audio
        mMicrophoneRecode = Microphone.Start(mDeviceName, true, lengthSec, frequency);
    }

    void Update(){
        volume = GetMaxVolume();
        print(volume);
    }
 

    void findMicrophones()
    {
        foreach (var device in Microphone.devices)
        {
            Debug.Log("Name: " + device);
        }
    }


    //  get max volume to analyze in a short period of time.
    private float GetMaxVolume()
    {
        float maxVolume = 0f;

        //用于储存一段时间内的音频信息
        float[] volumeData = new float[VOLUME_DATA_LENGTH];

        int offset;
        //获取录制的音频的开头位置
        offset = Microphone.GetPosition(mDeviceName) - VOLUME_DATA_LENGTH + 1;
        

        if(offset < 0)
        {
            return 0f;
        }

        //get data [maybe this is where it went wrong.]
        mMicrophoneRecode.GetData(volumeData, offset);

        //analyze data
        for(int i = 0;i < VOLUME_DATA_LENGTH; i++)
        {
            float tempVolume = volumeData[i];
            // Debug.Log(i, tempVolume); // data 

            if(tempVolume > maxVolume)
            {
                maxVolume = tempVolume;
            }
        }

        return maxVolume;
    }
}

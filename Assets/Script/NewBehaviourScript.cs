using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public static float volume;

    AudioClip micRecord;

    string device;

    // Use this for initialization
    void Start()
    {

        device = Microphone.devices[0];
        micRecord = Microphone.Start(device, true, 999, 44100);

    }

    // Update is called once per frame
    void Update()
    {
        volume = GetMaxVolume();
    }

    float GetMaxVolume()
    {
        float maxVolume = 0f;


        float[] volumeData = new float[128];
        int offset = Microphone.GetPosition(device) - 128 + 1;
        if (offset < 0)
        {
            return 0;
        }

        micRecord.GetData(volumeData, offset);
        for (int i = 0; i < 128; i++)
        {
            float tempMax = volumeData[i];
            if (maxVolume < tempMax)
            {
                maxVolume = tempMax;
            }
        }
        return maxVolume;

    }
}
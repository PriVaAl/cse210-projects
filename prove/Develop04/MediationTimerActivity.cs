using System;
using NAudio;
using NAudio.Wave;
public class MeditationTimerActivity : Activity
{
    private string _soundFilePath;


    public MeditationTimerActivity(string name, string description, int duration, string soundFilePath) :base(name, description, duration)
    {
        _soundFilePath = soundFilePath;
    }
    public void StartMeditation()
    {
        DisplayStartingMessage();
        Console.WriteLine("How long, in seconds, would you like for your sesion?");
        Console.WriteLine(" ");
        int duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Look for a place to lay down....");
        ShowSpinner(3);
        Console.WriteLine(" ");
        Console.WriteLine("You can close your eyes now and center your atention in your breathing, recognize your emotions.");
        ShowCountDown(5);
        Thread.Sleep(1000);
        PlayAlarmSound();
        DisplayEndingMessage(duration); 
        Console.WriteLine(" ");
        ShowSpinner(3);
    }

    private void PlayAlarmSound()
    {
        
        string soundFilePath = "alarm.wav";
        AudioFileReader audioFile =new AudioFileReader(soundFilePath);
        using (var outputDevice = new WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            while (outputDevice.PlaybackState == PlaybackState.Playing);
            {
                Console.WriteLine("");
            }

        }
        Console.WriteLine("Time is up");
    }
}
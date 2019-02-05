/*

Program by: Robert Dunski - 02/04/2019

Project #2 of Advanced Programming: C#

This program takes two western music scales and finds the notes played for each,
along with the corresponding note frequency

*/

using System;

enum Chromatic {A,ASharp,B,C,CSharp,D,DSharp,E,F,FSharp,G,GSharp};

interface MusicScale
{
  Chromatic NextNote();
}

class MusicNote : MusicScale //Inherit MusicScale
{
  public Chromatic currentNote;
  double aCal = Math.Pow(2.0,1.0/12.0); //Twelth root of 2
  double aFreq = 440;                   //Base frequency to start with

  public virtual Chromatic NextNote() //default implementation
  {
    currentNote = 0;
    return currentNote;
  }
  public double calcNote(Chromatic current)
  {
    return aFreq*Math.Pow(aCal,(double)current); //return 440 times calculated "a" to the power of the currentNote index
  }
}

class HarmonicScale : MusicNote //Inherit MusicNote, and subsequently inherit MusicScale as well
{
  int scaleCounter;             //Counter to keep track of where we are in the scale
  public HarmonicScale()        //Default constructor
  {
    scaleCounter = 0;
  }
  public override Chromatic NextNote(){
    if (scaleCounter == 0 || scaleCounter == 2 || scaleCounter == 3)
    {
      currentNote += 2;
      scaleCounter +=1;
    }
    else if (scaleCounter == 1 || scaleCounter== 4 || scaleCounter == 6)
    {
      currentNote += 1;
      scaleCounter +=1;
    }
    else if (scaleCounter == 5)
    {
      currentNote += 3;
      scaleCounter +=1;
    }
    if (scaleCounter == 7) { //If having to go through the scale twice, reset the counter
      scaleCounter = 0;
    }
    return currentNote;
  }
}

class BluesScale : MusicNote //The same, but different
{
  int scaleCounter;         //Counter to keep track of where we are in the scale
  public BluesScale()       //Default constructor
  {
    scaleCounter = 0;
  }
  public override Chromatic NextNote(){
    if (scaleCounter == 0 || scaleCounter == 4)
    {
      currentNote += 3;
      scaleCounter +=1;
    }
    else if (scaleCounter == 1 || scaleCounter== 5)
    {
      currentNote += 2;
      scaleCounter +=1;
    }
    else if (scaleCounter == 2 || scaleCounter == 3)
    {
      currentNote += 1;
      scaleCounter +=1;
    }
    if (scaleCounter == 7) {  //If having to go through the scale twice, reset the counter
      scaleCounter = 0;
    }
    return currentNote;
  }
}

namespace MusicScales
{
    class Program
    {
        static void Main(string[] args)
        {
            HarmonicScale hScale = new HarmonicScale();
            BluesScale bScale = new BluesScale();

            Console.WriteLine("Harmonic Minor Scale: \n");
            foreach(Chromatic i in Enum.GetValues(typeof(Chromatic))) //HarmonicScale loop
            {
              Console.WriteLine("Note {0}, which has frequency {1}", hScale.currentNote, hScale.calcNote(hScale.currentNote));
              hScale.NextNote();
              if ((double)hScale.currentNote == 12) //Back at the start
              {
                Console.WriteLine("Note {0}, which has frequency {1}",
                (Chromatic)((double)hScale.currentNote-12.0), hScale.calcNote(hScale.currentNote));
                break;
              }
            }

            Console.WriteLine("\nBlues Scale: \n");
            foreach(Chromatic i in Enum.GetValues(typeof(Chromatic))) //BluesScale loop
            {
              Console.WriteLine("Note {0}, which has frequency {1}", bScale.currentNote, bScale.calcNote(bScale.currentNote));
              bScale.NextNote();
              if ((double)bScale.currentNote == 12) //Back at the start
              {
                Console.WriteLine("Note {0}, which has frequency {1}",
                (Chromatic)((double)bScale.currentNote-12.0), bScale.calcNote(bScale.currentNote));
                break;
              }
            }

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}

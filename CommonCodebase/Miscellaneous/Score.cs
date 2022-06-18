﻿using System.Drawing;

namespace CommonCodebase.Miscellaneous;

public class Score : LabelBase
{
    public Score()
    {
        Text = "Score: ";

        Height = CalculateHeight();

        Color = Color.FromArgb(12, 216, 0);
    }

    public static int Height { get; private set; }

    public int ScoreToDraw { get; private set; }

    private int TotalScore { get; set; }

    private int CurrentScore { get; set; }

    public static event EventHandler? DrawScore;
    public static event EventHandler? UpdateScore;

    public override void Draw()
    {
        ScoreToDraw = TotalScore;
        DrawScore?.Invoke(this, EventArgs.Empty);
    }

    public void Update(object? sender, EventArgs e)
    {
        ScoreToDraw = TotalScore + ++CurrentScore;
        UpdateScore?.Invoke(this, EventArgs.Empty);
    }

    public void Save()
    {
        TotalScore += CurrentScore;
        ResetCurrent();
    }

    public void ResetAll()
    {
        TotalScore = 0;
        ResetCurrent();
    }

    public void ResetCurrent()
    {
        CurrentScore = 0;
    }
}
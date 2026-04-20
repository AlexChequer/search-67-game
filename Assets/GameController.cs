using UnityEngine;

public static class GameController
{
    private static int collectableCount;
    public static bool timerPaused = false;
    private static bool _timeOver = false;
    private static bool _initialized = false;
    public static float finalTime = 0f;
    public static int lives = 3;

    public static bool gameOver
    {
        get { return _initialized && (collectableCount <= 0 || _timeOver || lives <= 0); }
    }

    public static void SetTimeOver()
    {
        _timeOver = true;
        timerPaused = true;
    }

    public static void Init()
    {
        collectableCount = 8;
        _timeOver = false;
        timerPaused = false;
        _initialized = true;
        finalTime = 0f;
        lives = 3;
    }

    public static void Collect()
    {
        collectableCount--;
        if (collectableCount <= 0)
            timerPaused = true;
    }

    public static void LoseLife()
    {
        lives--;
        if (lives <= 0)
            timerPaused = true;
    }

    public static int score
    {
        get { return 8 - collectableCount; }
    }
}
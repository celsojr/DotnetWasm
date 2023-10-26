namespace DotnetWasm;

public static unsafe class Program
{
    public static int Main()
    {
        // Initialization
        //--------------------------------------------------------------------------------------
        const int screenWidth = 800;
        const int screenHeight = 450;

        InitWindow(screenWidth, screenHeight, "raylib [core] example - basic window");

        SetTargetFPS(60);
        //--------------------------------------------------------------------------------------

        uint fontSize = 20;
        sbyte* text = "Hey dev :)".ToSBytePtr();
        Vector2 screenSize = new Vector2(screenWidth, screenHeight);
        Vector2 position = new Vector2(((int)screenSize.X - MeasureText(text, (int)fontSize)) / 2, ((int)screenSize.Y - (int)fontSize) / 2);

        // Main game loop
        while (!WindowShouldClose())    // Detect window close button or ESC key
        {
            // Update
            //----------------------------------------------------------------------------------
            // TODO: Update your variables here
            //----------------------------------------------------------------------------------

            // Draw
            //----------------------------------------------------------------------------------
            BeginDrawing();
            ClearBackground(RAYWHITE);

            DrawText(text, (int)position.X, (int)position.Y, (int)fontSize, MAROON);

            EndDrawing();
            //----------------------------------------------------------------------------------
        }

        // De-Initialization
        //--------------------------------------------------------------------------------------
        CloseWindow();        // Close window and OpenGL context
        //--------------------------------------------------------------------------------------

        // Don't forget to free the memory :)
        Helper.FreeSbytePtr(text);

        return 0;
    }
}

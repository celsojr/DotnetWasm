namespace DotnetWasm;

public static class Program
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

                DrawText("Hey dev :)", 350, 200, 20, MAROON);

                EndDrawing();
                //----------------------------------------------------------------------------------
            }

            // De-Initialization
            //--------------------------------------------------------------------------------------
            CloseWindow();        // Close window and OpenGL context
            //--------------------------------------------------------------------------------------

            return 0;
    }
}

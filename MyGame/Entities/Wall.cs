﻿using System.Drawing;

namespace MyGame.Entities;

public class Wall : Cell
{
    public Wall(int x, int y) : base(x, y)
    {
        CellType = "#";
        CollisionType = Collision.Before;
        Color = Color.White;
    }
}
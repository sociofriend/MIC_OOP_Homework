﻿using System;
using ChessVersion3LibLilitAvdalyan20230511004;


namespace ChessVersion4LilitAvdalyan20230513005;

public class ChessFigureLegalSteps 
{
    /// <summary>
    /// Runs GetFigure(), GetCoordinates() and PrintBoard(string figure, int[] coordinates) methods.
    /// Prints the board with given figure on given coordinates' cell.
    /// </summary>
    public void RunChess()
    {
        PrintBoard(GetFigure(), GetCoordinates());
        Console.WriteLine();
        RunChess();
    }

    /// <summary>
    /// Gets user input for chess figure to print on the board.Type: string. 
    /// </summary>
    /// <returns>Returns string type value.</returns>
    string GetFigure()
    {
        Console.WriteLine("Choose a figure: press R for rook, N " +
            "for knight, B for bishop, K for king and Q for queen.");

        //string letters = "RNBKQ";
        string figure = Console.ReadLine().ToUpper();


        if (figure!=null && Enum.TryParse<HotKeys>(figure, out HotKeys result))
        {
            return figure;
        }
        else
        {
            Console.WriteLine("WRONG INPUT: Please input a letter from the suggested options.");
            return GetFigure();
        }
    }


    /// <summary>
    /// Gets user input on coordinates for identifying on which chell to print the figure.
    /// </summary>
    /// <returns>Returns a two-dimensional array of integers.</returns>
    int[,] GetCoordinates()
    {
        int[,] coordinates = new int[8, 8];
        Console.WriteLine("Input command, where first symbol is a letter " +
            "from ՛a՛ to ՛h՛ or 'A' to 'H' and second command is a number from ՛1՛ to ՛8՛ (ex.a8 or H1)");
        string input = Console.ReadLine().ToUpper();

        if ((input.Length == 2) && (input[0] >= 65 && input[0] <= 72) &&
            (input[1] >= 49 && input[1] <= 56))
        {
            coordinates[((int)input[1] - 49), ((int)input[0] - 65)] = 1;
            return coordinates;
        }
        else
        {
            Console.WriteLine("WRONG INPUT: Please input two-symbol command");
            return GetCoordinates();
        }
    }


    /// <summary>
    /// Prints the chess board with user inputs for figure and coordinates. For chess common features uses ChessLib
    /// </summary>
    /// <param name="figure"></param>
    /// <param name="coordinates"></param>
    void PrintBoard(string figure, int[,] coordinates)
    {
        switch(figure)
        {
            //case "K": 
            //    break;
            case "R":
                Rook.BoardPrinterWithLegalSteps(figure, coordinates);
                RunChess();
                break;
            //case "N":
            //    break;
            case "B":
                Bishop.BoardPrinterWithLegalSteps(figure, coordinates);
                RunChess();
                break;
            case "Q":
                Queen.BoardPrinterWithLegalSteps(figure, coordinates);
                RunChess();
                break;
        }
        
    }
}

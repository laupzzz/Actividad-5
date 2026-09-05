using System;
using System.Threading;
using System.IO;
namespace ConwaysGamesOfLife
{
    public static class LectorArchivo
    {
        public static bool[,] Lector(string path)
        {
            string content = File.ReadAllText(path);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            for (int  y=0; y<contentLines.Length;y++)
            {
                for (int x=0; x<contentLines[y].Length; x++)
                {
                    if(contentLines[y][x]=='1')
                    {
                        board[x,y]=true;
                    }
                }
            }
            return board;
                        
                    }
                }
            }
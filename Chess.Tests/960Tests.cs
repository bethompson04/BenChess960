using Chess.Core;
using Chess.Core.Pieces;
using System.Diagnostics;


namespace Chess.Tests
{
    public class _960Tests
    {
        // Randomized indexes for board pieces
        // 1 = King | 2 = Queen | 3 = Bishop | 4 = Knight | 5 = Rook
        [Fact]
        public void KingIsBetweenRooks()
        {
            var board = new Board(8, true, true);

            // Check king and rook positions
            int KingPos = board.piecePos.IndexOf(1);
            int RookPos1 = board.piecePos.IndexOf(5);
            int RookPos2 = board.piecePos.LastIndexOf(5);

            bool isBetween = (RookPos1 < KingPos) && (KingPos < RookPos2);

            Assert.True(isBetween);
        }

        [Fact]
        public void KingIsNOTBetweenRooks()
        {
            var board = new Board(8, true, true);

            // Check king and rook positions
            int KingPos = board.piecePos.IndexOf(1);
            int RookPos1 = board.piecePos.IndexOf(5);
            int RookPos2 = board.piecePos.LastIndexOf(5);

            bool isBetween = !((RookPos1 < KingPos) && (KingPos < RookPos2));

            Assert.False(isBetween);
        }

        [Fact]
        public void BishopsOnOppositeTile()
        {
            var board = new Board(8, true, true);

            // Check Bishops' positions

            int Bishop1 = board.piecePos.IndexOf(3);
            int Bishop2 = board.piecePos.LastIndexOf(3);

            bool Bishop1Even = (Bishop1 % 2) == 0;
            bool Bishop2Even = (Bishop2 % 2) == 0;

            bool oppositeTile = (Bishop1Even != Bishop2Even);

            Assert.True(oppositeTile);
        }


        [Fact]
        public void BishopsNOTOnOppositeTile()
        {
            var board = new Board(8, true, true);

            // Check Bishops' positions

            int Bishop1 = board.piecePos.IndexOf(3);
            int Bishop2 = board.piecePos.LastIndexOf(3);

            bool Bishop1Even = (Bishop1 % 2) == 0;
            bool Bishop2Even = (Bishop2 % 2) == 0;

            bool oppositeTile = (Bishop1Even == Bishop2Even);
            Debug.Print(Bishop1.ToString());
            Debug.Print(Bishop2.ToString());

            Assert.False(oppositeTile);
        }


        [Fact]
        public void AllPiecesPlaced()
        {
            var board = new Board(8, true, true);

            bool allPiecesPlaced = true;

            for (int i = 0; i < 8; i++)
            {
                if (board.piecePos[i] == 0) allPiecesPlaced = false;
            }

            Assert.True(allPiecesPlaced);
        }

        [Fact]
        public void DifferentThanStandardLayout()
        {
            // 1 = King | 2 = Queen | 3 = Bishop | 4 = Knight | 5 = Rook
            // DEFAULT: -- Rook, Knight, Bishop, Queen, King, Bishop, Knight, Rook --
            // 0,7 : Rook
            // 1,6 : Knight
            // 2,5 : Bishop
            //  3  : Queen
            //  4  : King
            var board = new Board(8, true, true);

            bool rook1 = board.piecePos[0] == 5;
            bool rook2 = board.piecePos[7] == 5;
            bool knight1 = board.piecePos[1] == 4;
            bool knight2 = board.piecePos[6] == 4;
            bool bishop1 = board.piecePos[2] == 3;
            bool bishop2 = board.piecePos[5] == 3;
            bool queen = board.piecePos[3] == 2;
            bool king = board.piecePos[4] == 1;


            bool standardLayout = rook1 && rook2 && knight1 && knight2 && bishop1 && bishop2 && queen && king;

            Assert.False(standardLayout);
        }



    }
}

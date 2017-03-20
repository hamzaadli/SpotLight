
$(document).ready(function() {

    var player = 1;
    var table = $('table');
    var messages = $('.results');
    var turn = $('.playerturn');
    var cell = $('td');
    displayPlayerTurn(turn, player);

    cell.click(function () {
        td = $(this);
        var state = checkCellState(td);
        messages.html('');
        // if the cell was marked 
        if (!state) {
            var pattern = markPlayerMove(player);
            UpdatePlayerState(td, pattern);

            if (checkWhoWon(table, pattern)) {
                messages.html('Player ' + player + ' has won.');
                turn.html('');
            }
            else {
                player = setNextPlayer(player);
                displayPlayerTurn(turn, player);
            }
        } else {
            messages.html('Cant Check This Box.');
        }
    });

   
    function checkCellState(td) {
        return td.hasClass('cross') || td.hasClass('circle');
      }

    function UpdatePlayerState(td, pattern) {
        return td.addClass(pattern);
    }

    function markPlayerMove(player) {
        return player == 1 ? 'cross' : 'circle';
    }

    function setNextPlayer(player) {
        return player == 1 ? 2 : 1;
    }

    function displayPlayerTurn(turn, player) {
        turn.html('Player turn : ' + player);
    }

    function checkWhoWon(table, pattern) {
        var won = 0;
        if (table.find('.cell1').hasClass(pattern) && table.find('.cell2').hasClass(pattern) && table.find('.cell3').hasClass(pattern)) {
            won = 1;
        } else if (table.find('.cell1').hasClass(pattern) && table.find('.cell4').hasClass(pattern) && table.find('.cell7').hasClass(pattern)) {
            won = 1;
        } else if (table.find('.cell1').hasClass(pattern) && table.find('.cell5').hasClass(pattern) && table.find('.cell9').hasClass(pattern)) {
            won = 1;
        } else if (table.find('.cell4').hasClass(pattern) && table.find('.cell5').hasClass(pattern) && table.find('.cell6').hasClass(pattern)) {
            won = 1;
        } else if (table.find('.cell7').hasClass(pattern) && table.find('.cell8').hasClass(pattern) && table.find('.cell9').hasClass(pattern)) {
            won = 1;
        } else if (table.find('.cell2').hasClass(pattern) && table.find('.cell5').hasClass(pattern) && table.find('.cell8').hasClass(pattern)) {
            won = 1;
        } else if (table.find('.cell3').hasClass(pattern) && table.find('.cell6').hasClass(pattern) && table.find('.cell9').hasClass(pattern)) {
            won = 1;
        } else if (table.find('.cell3').hasClass(pattern) && table.find('.cell5').hasClass(pattern) && table.find('.cell7').hasClass(pattern)) {
            won = 1;
        }
        return won;
    }

   
});


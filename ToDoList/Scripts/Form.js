function responsive(ids) {
    function Animation(id) {
        if ($('#' + id[0]).val()) {
            $('#' + id[1]).animate({
                left: '500px',
                opacity: '0.5',
                float:'left'
            }, "slow");
        }
    }
    ids.forEach(Animation)
}


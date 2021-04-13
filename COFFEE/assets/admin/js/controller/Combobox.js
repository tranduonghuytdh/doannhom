jQuery(function () {
    (function ($) { //
        $('select[class^=combobox]').each(function () { //chay ham nay voi tat ca select box co class="combobox"

            var id = 'txt_' + this.id; //tao 1 id cho textbox
            while ($(id).size()) //kiem tra tinh duy nhat cua id
                id += 'a';
            //tao html cua 1 textbox
            var html = '<input type="text" name="' + this.name + '" class="combobox-textbox" id="' + id + '" />';
            $(this).parent().append(html); //them 1 textbox vào form
            $('#' + id).val($('option[value=' + this.value + ']').html()); //set value hien tai vao html
            $(this).change(function () { //khi select 1 option
                $('#' + id).val($('option[value=' + this.value + ']').html()); //set innerHTML cua option vao textbox
            });
            //dat vi tri cua textbox
            $('#' + id).css('position', 'absolute'); //set position
            $('#' + id).offset($(this).offset()); //copy offset
            $('#' + id).height($(this).height()); //set height
            $('#' + id).width($(this).width() - $(this).height()); //set width
            $('#' + id).css('border', 'none'); //special style for firefox
            $('#' + id).css('margin-top', '1px');
            $('#' + id).css('margin-left', '1px');
        });
    })(jQuery);
})
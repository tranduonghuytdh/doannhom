/**
 * @license Copyright (c) 2003-2020, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see https://ckeditor.com/legal/ckeditor-oss-license
 */

CKEDITOR.editorConfig = function( config ) {
	// Define changes to default configuration here. For example:
	// config.language = 'fr';
	// config.uiColor = '#AADC6E';
	//config.extraPlugins = "syntaxhighlight";
	config.syntaxhighlight = "Csharp";
	config.syntaxhighlight_hideControls = true;
	config.language = "vi";
	filebrowserBrowseUrl = '/Assets/Admin/js/Plugins/ckeditor_4.15.0_full/ckfinder/ckfinder.html';
	filebrowserImageBrowseUrl = '/Assets/Admin/js/Plugins/ckfinder/ckfinder.html?type=Images';
	filebrowserFlashBrowseUrl = '/Assets/Admin/js/Plugins/ckfinder/ckfinder.html?type=Flash';
	filebrowserUploadUrl = '/Assets/Admin/js/Plugins/ckfinder/connector?command=QuickUpload&type=Files';
	filebrowserImageUploadUrl = '/Data';
	filebrowserFlashUploadUrl = '/Assets/Admin/js/Plugins/ckfinder/connector?';
	CKFinder.setupCKEditor(null, '/Assets/Admin/js/Plugins/ckfinder/');
};
	

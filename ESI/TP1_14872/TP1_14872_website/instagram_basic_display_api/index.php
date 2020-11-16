<?php
	require_once( 'instagram_basic_display_api.php' );

	$accessToken = 'IGQVJWeElWY2liU1ljV2V5SnpzRENoUmFHRHhOMU9Ja2VmckZAzcWozT2RNNEJHODc1T1V0d2w5M1R4dU1iMDVCdV96Sm82UWZAyZAUFDNHk2MVBqYTctNzJjWXZAhWkxIRi1mTHFKejExQ3ZApOEZAvdzU2aE5CR1prRnBQQU13';
	$userId = '17841439509141880';

	$params = array(
		'get_code' => isset( $_GET['code'] ) ? $_GET['code'] : '',
		'access_token' => $accessToken,
		'user_id' => $userId
	);
	$ig = new instagram_basic_display_api( $params );
	
	if ( $ig->hasUserAccessToken ) {
		$response = array(
			'user_id' => $userId,
			'access_token' => $ig->getUserAccessToken()
		);
		echo json_encode($response);
	} else
		header("Location: ".$ig->authorizationUrl);
?>
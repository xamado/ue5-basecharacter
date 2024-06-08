// Copyright Epic Games, Inc. All Rights Reserved.

#include "TestBaseCharacterGameMode.h"
#include "TestBaseCharacterCharacter.h"
#include "UObject/ConstructorHelpers.h"

ATestBaseCharacterGameMode::ATestBaseCharacterGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}

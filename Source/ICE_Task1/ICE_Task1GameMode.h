// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "ICE_Task1GameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class AICE_Task1GameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	AICE_Task1GameMode();
};




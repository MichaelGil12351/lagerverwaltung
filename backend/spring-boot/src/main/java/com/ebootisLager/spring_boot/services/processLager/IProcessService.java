package com.ebootis.spring_boot.services.processLager;

import com.ebootis.spring_boot.dtos.ProcessPositionDTO;
import com.ebootis.spring_boot.models.ProcessPosition;
import com.ebootis.spring_boot.services.generic.ICombinedGenericService;

public interface IProcessService extends ICombinedGenericService<ProcessPosition, ProcessPositionDTO,Integer> {
}

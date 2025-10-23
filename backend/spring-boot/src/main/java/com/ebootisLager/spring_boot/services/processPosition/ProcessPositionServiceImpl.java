package com.ebootis.spring_boot.services.processPosition;

import com.ebootis.spring_boot.dtos.ProcessPositionDTO;
import com.ebootis.spring_boot.mappers.IMapper;
import com.ebootis.spring_boot.models.ProcessPosition;
import com.ebootis.spring_boot.repositories.IProcessPositionRepository;
import com.ebootis.spring_boot.services.generic.CombinedGenericServiceImpl;
import org.springframework.stereotype.Service;

@Service
public  class ProcessPositionServiceImpl extends CombinedGenericServiceImpl<ProcessPosition, ProcessPositionDTO,Integer> implements IProcessPositionService {

    public ProcessPositionServiceImpl(IProcessPositionRepository repository, IMapper<ProcessPosition, ProcessPositionDTO> mapper) {
        super(repository, mapper);
    }
}
